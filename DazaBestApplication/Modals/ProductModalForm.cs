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
        private byte[]? Pic = null;


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
                if (_productmodal.EditItem.ProductImage != null)
                {
                    AddProductPic.Image = Image.FromStream(new MemoryStream(_productmodal.EditItem.ProductImage)!);
                }
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
                ProductPicture = Pic
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
        //Edit Product
        private async Task EditProduct()
        {
            _productservices = new ProductServices(new BackEndDBContext());
            EditProduct editproduct = new EditProduct()
            {
                ProductID = ProducteditID,
                ProductName = ProductNametxt.Text,
                ProductPrice = decimal.Parse(Productpricetxt.Text),
                ProductImage = Pic
            };
            bool IsEdited = await _productservices.UpdateProduct(editproduct);
            if (IsEdited)
            {
                Closemodal();
                await ProductEventHandlers.InvokeProductChanged();
                MessageBox.Show("Changes Saved Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to Save Changes", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if(string.IsNullOrWhiteSpace(ProductNametxt.Text) || string.IsNullOrWhiteSpace(Productpricetxt.Text) || AddProductPic.Image is null || ProductCategories.SelectedIndex ==-1)
                {
                    MessageBox.Show("Please fill in all required fields.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    AddNewProduct();
                }
                
            }
            else
            {
                EditProduct();
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Closemodal();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Pic = File.ReadAllBytes(openFileDialog.FileName);
                        AddProductPic.Image = Image.FromStream(new MemoryStream(Pic));

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}");
                        Pic = null;
                    }
                }
            }
        }

        private void ProductNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void Productpricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
