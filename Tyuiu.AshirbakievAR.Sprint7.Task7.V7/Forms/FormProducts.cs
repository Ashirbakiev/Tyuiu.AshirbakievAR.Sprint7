using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.AshirbakievAR.Sprint7.Task7.V7.Lib;


namespace Tyuiu.AshirbakievAR.Sprint7.Task7.V7.Forms
{
    public partial class FormProducts : Form
    {
        public BindingList<Product> productList;
        private BindingSource bindingSource;
        private SortOrder currentSortOrder = SortOrder.Ascending;
        DataService ds = new DataService();
        public class Product
        {
            public int Apartment { get; set; }
            public int Entrance { get; set; }
            public int Fullarea { get; set; }
            public int Usefularea { get; set; }
            public int Rooms { get; set; }
            public string Name { get; set; }
            public string Date { get; set; }
            public int Members { get; set; }
            public int Children { get; set; }
            public bool Debt { get; set; }

            public Product(int apartment, int entrance, int fullarea, int usefularea, int rooms, string name, string date, int members, int children, bool debt)
            {
                Apartment = apartment;
                Entrance = entrance;
                Fullarea = fullarea;
                Usefularea = usefularea;
                Rooms = rooms;
                Name = name;
                Date = date;
                Members = members;
                Children = children;
                Debt = debt;
            }
            public Product()
            {

            }

        }
        public FormProducts()
        {
            InitializeComponent();
            productList = new BindingList<Product>();
            bindingSource = new BindingSource(productList, null);
            // Привязываем источник данных к DataGridView
            dataGridViewInfo_AAR.DataSource = bindingSource;

            dataGridViewInfo_AAR.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            textBoxSearch_AAR.TextChanged += textBox_Search_AAR_TextChanged;
            comboBoxSortInput_AAR.SelectedIndex = 0;
            comboBoxChart_AAR.SelectedIndex = 0;
        }
        private void FormProducts_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in panel1.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            foreach (Control btns in panel2.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int Apartment = Convert.ToInt32(textBoxApartment_AAR.Text);
                int Entrance = Convert.ToInt32(textBoxEntrance_AAR.Text);
                int Fullarea = Convert.ToInt32(textBoxFullarea_AAR.Text);
                int Usefularea = Convert.ToInt32(textBoxUsefularea_AAR.Text);
                int Rooms = Convert.ToInt32(textBoxRooms_AAR.Text);
                string Name = textBoxName_AAR.Text;
                string Date = textBoxDate_AAR.Text;
                int Members = Convert.ToInt32(textBoxMembers_AAR.Text);
                int Children = Convert.ToInt32(textBoxChildren_AAR.Text);
                bool Debt = checkBoxDebt_AAR.Checked;

                // Создаем объект продукта
                Product newProduct = new Product(Apartment, Entrance, Fullarea, Usefularea, Rooms, Name, Date, Members, Children, Debt);

                // Добавляем продукт в список
                productList.Add(newProduct);

                // Очищаем текстовые поля после добавления
                textBoxApartment_AAR.Clear();
                textBoxEntrance_AAR.Clear();
                textBoxFullarea_AAR.Clear();
                textBoxUsefularea_AAR.Clear();
                textBoxRooms_AAR.Clear();
                textBoxName_AAR.Clear();
                textBoxDate_AAR.Clear();
                textBoxMembers_AAR.Clear();
                textBoxChildren_AAR.Clear();
                checkBoxDebt_AAR.Checked = false;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все фалы(*.*)|*.*";
                openFileDialog.Title = "Выберите CSV файл для открытия";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Читаем все строки из файла
                    string[] lines = File.ReadAllLines(filePath);

                    // Парсим заголовки столбцов
                    string[] headers = lines[0].Split(';');

                    // Очищаем старые данные в BindingList
                    productList.Clear();

                    // Заполняем BindingList данными из файла
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] values = lines[i].Split(';');
                        productList.Add(new Product {
                            Apartment = Convert.ToInt32(values[0]),
                            Entrance = Convert.ToInt32(values[1]),
                            Fullarea = Convert.ToInt32(values[2]),
                            Usefularea = Convert.ToInt32(values[3]),
                            Rooms = Convert.ToInt32(values[4]),
                            Name = values[5],
                            Date = values[6],
                            Members = Convert.ToInt32(values[7]),
                            Children = Convert.ToInt32(values[8]),
                            Debt = Convert.ToBoolean(values[9])
                        });
                    }

                    MessageBox.Show("Файл успешно открыт!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SortDataGridViewByColumn(string columnName)
        {
            if (currentSortOrder == SortOrder.Ascending)
            {
                bindingSource.DataSource = new BindingList<Product>(productList.OrderBy(x => typeof(Product).GetProperty(columnName).GetValue(x)).ToList());
                currentSortOrder = SortOrder.Descending;
            }
            else
            {
                bindingSource.DataSource = new BindingList<Product>(productList.OrderByDescending(x => typeof(Product).GetProperty(columnName).GetValue(x)).ToList());
                currentSortOrder = SortOrder.Ascending;
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                string directoryPath = $@"{Directory.GetCurrentDirectory()}";
                string fileName = "TableOfProducts.csv";
                string path = Path.Combine(directoryPath, fileName);


                // Создаем строку для записи заголовков столбцов
                string header = string.Join(";", dataGridViewInfo_AAR.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText));

                // Создаем строки для каждой записи данных
                List<string> lines = new List<string>();
                foreach (DataGridViewRow row in dataGridViewInfo_AAR.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string line = string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value.ToString()));
                        lines.Add(line);
                    }
                }

                // Соединяем заголовок и строки вместе
                string content = header + Environment.NewLine + string.Join(Environment.NewLine, lines);

                // Записываем содержимое в файл
                File.WriteAllText(path, content);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SearchInDataGridView(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                // Если поле поиска пусто, отобразите все данные
                dataGridViewInfo_AAR.DataSource = bindingSource;
            }
            else
            {
                // Иначе выполните поиск и отобразите результаты
                var searchResults = productList.Where(product =>
                    product.Apartment.ToString().Contains(searchText) ||
                    product.Entrance.ToString().Contains(searchText) ||
                    product.Fullarea.ToString().Contains(searchText) ||
                    product.Usefularea.ToString().Contains(searchText) ||
                    product.Rooms.ToString().Contains(searchText) ||
                    product.Name.Contains(searchText) ||
                    product.Date.Contains(searchText) ||
                    product.Members.ToString().Contains(searchText) ||
                    product.Children.ToString().Contains(searchText) ||
                    product.Debt.ToString().Contains(searchText)



                ).ToList();

                dataGridViewInfo_AAR.DataSource = new BindingList<Product>(searchResults);
            }
        }
        private void textBox_Search_AAR_TextChanged(object sender, EventArgs e)
        {
            SearchInDataGridView(textBoxSearch_AAR.Text);
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            try
            {
                string sortName = comboBoxSortInput_AAR.SelectedItem.ToString(); ; ;
                SortDataGridViewByColumn(sortName);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при вводе данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewInfo_AAR.SelectedRows.Count > 0)
            {
                // Получить выбранную строку
                DataGridViewRow selectedRow = dataGridViewInfo_AAR.SelectedRows[0];

                // Получить объект продукта из выбранной строки
                Product selectedProduct = (Product)selectedRow.DataBoundItem;

                // Удалить продукт из списка
                productList.Remove(selectedProduct);
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridViewInfo_AAR.SelectedRows.Count > 0)
            {
                // Получить выбранную строку
                DataGridViewRow selectedRow = dataGridViewInfo_AAR.SelectedRows[0];

                // Получить объект продукта из выбранной строки
                try
                {
                    Product selectedProduct = (Product)selectedRow.DataBoundItem;
                    selectedProduct.Apartment = Convert.ToInt32(textBoxApartment_AAR.Text);
                    selectedProduct.Entrance = Convert.ToInt32(textBoxEntrance_AAR.Text);
                    selectedProduct.Fullarea = Convert.ToInt32(textBoxFullarea_AAR.Text);
                    selectedProduct.Usefularea = Convert.ToInt32(textBoxUsefularea_AAR.Text);
                    selectedProduct.Rooms = Convert.ToInt32(textBoxRooms_AAR.Text);
                    selectedProduct.Name = textBoxName_AAR.Text;
                    selectedProduct.Date = textBoxDate_AAR.Text;
                    selectedProduct.Members = Convert.ToInt32(textBoxMembers_AAR.Text);
                    selectedProduct.Children = Convert.ToInt32(textBoxChildren_AAR.Text);
                    selectedProduct.Debt = checkBoxDebt_AAR.Checked;
                    textBoxApartment_AAR.Clear();
                    textBoxEntrance_AAR.Clear();
                    textBoxFullarea_AAR.Clear();
                    textBoxUsefularea_AAR.Clear();
                    textBoxRooms_AAR.Clear();
                    textBoxName_AAR.Clear();
                    textBoxDate_AAR.Clear();
                    textBoxMembers_AAR.Clear();
                    textBoxChildren_AAR.Clear();
                    checkBoxDebt_AAR.Checked = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при вводе данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            try
            {
                chart_AAR.Series.Clear();
                if (comboBoxChart_AAR.SelectedItem.ToString() == "Area")
                {
                    chart_AAR.Series.Add("UsefulareaMax");
                    chart_AAR.Series.Add("UsefulareaMin");
                    chart_AAR.Series.Add("UsefulareaAverege");

                    chart_AAR.Series.Add("FullareaMax");
                    chart_AAR.Series.Add("FullareaMin");
                    chart_AAR.Series.Add("FullareaAverege");
                    int row = dataGridViewInfo_AAR.RowCount;
                    int[] matrix = new int[row - 1];
                    int[] matrix2 = new int[row - 1];
                    for (int i = 0; i < row - 1; i++)
                    {
                        matrix[i] = Convert.ToInt32(dataGridViewInfo_AAR.Rows[i].Cells[2].Value);
                        matrix2[i] = Convert.ToInt32(dataGridViewInfo_AAR.Rows[i].Cells[3].Value);
                    }

                    chart_AAR.Series["UsefulareaMax"].Points.AddXY("", ds.Max(matrix));
                    chart_AAR.Series["UsefulareaAverege"].Points.AddXY("", ds.Avarege(matrix));
                    chart_AAR.Series["UsefulareaMin"].Points.AddXY("", ds.Min(matrix));

                    chart_AAR.Series["FullareaMax"].Points.AddXY("", ds.Max(matrix2));
                    chart_AAR.Series["FullareaMin"].Points.AddXY("", ds.Avarege(matrix2));
                    chart_AAR.Series["FullareaAverege"].Points.AddXY("", ds.Min(matrix2));
                }
                else
                {
                    chart_AAR.Series.Add("Dept");
                    chart_AAR.Series.Add("No Dept");
                    int row = dataGridViewInfo_AAR.RowCount;
                    bool[] matrix = new bool[row - 1];
                    for (int i = 0; i < row - 1; i++)
                    {
                        matrix[i] = Convert.ToBoolean(dataGridViewInfo_AAR.Rows[i].Cells[9].Value);
                    }
                    chart_AAR.Series["Dept"].Points.AddXY("", ds.Dept(matrix));
                    chart_AAR.Series["No Dept"].Points.AddXY("", ds.NoDept(matrix));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при вводе данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
