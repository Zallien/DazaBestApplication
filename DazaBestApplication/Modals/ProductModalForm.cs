using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;
using SystemBackEnd.Models;
using SystemBackEnd;
using SystemBackEnd.EventHandlers;

namespace DazaBestApplication.Modals
{
    public partial class ProductModalForm : Form
    {

        private ProductModal _productmodal;
        private ProductServices _productservices = new ProductServices(new BackEndDBContext());
        private Guid ProducteditID;


        //Constructor
        public ProductModalForm(ProductModal product)
        {
            InitializeComponent();
            _productmodal = product;
        }

        //Main Load
        private void ProductModalForm_Load(object sender, EventArgs e)
        {
            CheckModalType();
        }
        //Close Modal
        private void Closemodal()
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
        //Checks if the modal is for edit or add
        private void CheckModalType()
        {
            if (_productmodal.Action == "AddProduct")
            {
                Modaltitle.Text = "Add Product";
                ProductModalButton.Text = "Add Product";
            }
            else
            {
                Modaltitle.Text = "Edit Product";
                ProductModalButton.Text = "Save Changes";
                ProducteditID = _productmodal.EditItem.ProductID;
                ProductNametxt.Text = _productmodal.EditItem.ProductName;
                Productpricetxt.Text = _productmodal.EditItem.ProductPrice.ToString("#.##0");
            }
        }
        //Add Product
        private async Task AddNewProduct()
        {
            _productservices = new ProductServices(new BackEndDBContext());
            InsertProduct newproduct = new InsertProduct()
            {
                ProductName = ProductNametxt.Text,
                ProductPrice = decimal.Parse(Productpricetxt.Text),
            };
            bool IsAdded = await _productservices.AddProduct(newproduct);
            if (IsAdded)
            {
                Closemodal();
                await ProductEventHandlers.InvokeProductChanged();
                MessageBox.Show("Added Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Failed to Add Product", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        //Evemts
        private void CloseModal_Click(object sender, EventArgs e)
        {
            Closemodal();
        }

        private void ProductModalButton_Click(object sender, EventArgs e)
        {
            if (_productmodal.Action == "AddProduct")
            {
                AddNewProduct();
            }
        }
    }
}
