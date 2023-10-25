using Lab_2.DTOs;
using Lab_2.Models;
using Lab_2.Services.IServices;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        private List<ProductOrderDTO> orderList = new List<ProductOrderDTO>();

        ICategoryService categoryService;
        ICustomerService customerService;
        IEmployeeService employeeService;
        IOrderDetailService orderDetailService;
        IOrderService orderService;
        IProductService productService;
        IShipperService shipperService;

        public Form1(
            ICategoryService _categoryService,
            ICustomerService _customerService,
            IEmployeeService _employeeService,
            IOrderDetailService _orderDetailService,
            IOrderService _orderService,
            IProductService _productService,
            IShipperService _shipperService)
        {

            categoryService = _categoryService;
            customerService = _customerService;
            employeeService = _employeeService;
            orderDetailService = _orderDetailService;
            orderService = _orderService;
            productService = _productService;
            shipperService = _shipperService;
            InitializeComponent();


            dgvListProduct.CellClick += DgvListProduct_CellClick;
            dgvOrderList.CellEndEdit += DgvOrderList_CellEndEdit;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbTotalPrice.Text = (0).ToString();

            cbCustomers.DisplayMember = "CompanyName";
            cbCustomers.ValueMember = "CustomerId";
            List<Customer> customers = customerService.GetCustomers();

            cbCustomers.DataSource = customers;

            cbEmployees.DisplayMember = "FirstName";
            cbEmployees.ValueMember = "EmployeeId";
            List<Employee> employees = employeeService.GetEmployees();
            cbEmployees.DataSource = employees;



            dtpRequireDate.Value = DateTime.Now;


            List<GetListProductDTO> products = productService.getAllProduct();
            dgvListProduct.DataSource = products;
            dgvListProduct.ReadOnly = true;

        }

        private void DgvListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvListProduct.Rows[e.RowIndex];
                int productId = Convert.ToInt32(row.Cells["ProductId"].Value);
                string productName = row.Cells["ProductName"].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                decimal total = Convert.ToDecimal(tbTotalPrice.Text);
                if (!checkProductIdExist(productId))
                {
                    ProductOrderDTO selectedProduct = productService.getProductById(productId);
                    if (selectedProduct != null)
                    {
                        orderList.Add(selectedProduct);

                    }
                }
                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = orderList;
                dgvOrderList.Columns["ProductID"].ReadOnly = true;
                dgvOrderList.Columns["ProductName"].ReadOnly = true;
            }
        }

        private bool checkProductIdExist(int id)
        {
            return orderList.Any(p => p.ProductID == id);
        }


        private void DgvOrderList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal total = Convert.ToDecimal(tbTotalPrice.Text);

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvOrderList.Rows[e.RowIndex];
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                int productId = Convert.ToInt32(row.Cells["ProductID"].Value);

                bool checkUnitInStock = productService.checkUnitInStock(productId, quantity);
                if (!checkUnitInStock)
                {
                    MessageBox.Show("Số lượng vượt quá tồn kho. Vui lòng kiểm tra lại!");

                    row.Cells["Quantity"].Value = Convert.ToString(0);
                    UpdatePrice();
                }
                else
                {
                    if (dgvOrderList.Columns[e.ColumnIndex].Name == "Quantity")
                    {
                        UpdatePrice();
                    }
                }
            }
        }

        private void UpdatePrice()
        {

            decimal? total = 0;
            foreach (var item in orderList)
            {
                decimal? price = productService.getPriceById(item.ProductID);
                if (price != null)
                {
                    total += price.Value * item.Quantity;
                }
            }
            tbTotalPrice.Text = total.ToString();
        }

        private void AddOrder()
        {
            bool check = false;
            string? customerId = cbCustomers.SelectedValue.ToString();
            int employeeId = Convert.ToInt32(cbEmployees.SelectedValue);
            DateTime orderDate = DateTime.Now;
            DateTime requireDate = dtpRequireDate.Value;
            string address = tbAddress.Text;

            string city = tbCity.Text;

            string country = tbCountry.Text;
            if (address == "" || city == "" || country == "")
            {
                MessageBox.Show("Ship data can not be empty");
                return;
            }

            foreach (var item in orderList)
            {
                if (item.Quantity > 0)
                {
                    check = true;
                }

            }

            if(!check)
            {
                MessageBox.Show("Quantity = 0");
                return;
            }

            Order newOrder = new Order
            {
                CustomerId = customerId,
                EmployeeId = employeeId,
                OrderDate = orderDate,
                RequiredDate = requireDate,
                ShipAddress = address,
                ShipCity = city,
                ShipCountry = country
            };

            orderService.AddNewOrder(newOrder);

            foreach (var item in orderList)
            {
                if (item.Quantity > 0)
                {
                    OrderDetail orderDetail = new OrderDetail
                    {
                        OrderId = newOrder.OrderId,
                        ProductId = item.ProductID,
                        UnitPrice = productService.getPriceById(item.ProductID) ?? 0,
                        Quantity = item.Quantity,

                    };
                    check = true;
                    orderDetailService.AddNewOrderDetail(orderDetail);
                }

            }

            MessageBox.Show("Successfully");
            dgvOrderList.DataSource = null;


        }




        private void cbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbShipper_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpRequireDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpRequireDate.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày yêu cầu không thể nhỏ hơn ngày hiện tại. Vui lòng kiểm tra lại!");
                dtpRequireDate.Value = DateTime.Now;
            }

        }

        private void tbTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrder();
        }
    }
}