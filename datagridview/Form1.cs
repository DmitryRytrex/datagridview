using System.Data;

namespace datagridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (DataBase db = new DataBase())
            {
              DataTable users = db.ExecuteSql("SELECT * FROM USERS");
              dataGridView1.DataSource = users;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateForm create = new CreateForm();
            create.Show();
        }
    }
}