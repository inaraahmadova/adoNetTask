using System.Data.SqlClient;

namespace spotifyTask
{
    public partial class Form1 : Form
    {
        const string connectionString = "Server=LAPTOP-ACG39MDK\\SQLEXPRESS;Database=Spotify;Trusted_Connection=True;";

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sutunlar();
            GetDatas();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string ad = nameInput.Text;
            string soyad = surnameInput.Text;
            CreateData(ad, soyad);
            nameInput.Text = "";
            surnameInput.Text = "";
            GetDatas();
        }

        private void Sutunlar()
        {
            dataGridView1.Columns.Add("id", "Id");
            dataGridView1.Columns.Add("name", "Name");
            dataGridView1.Columns.Add("surname", "Surname");
        }
        void GetDatas()
        {
            dataGridView1.Rows.Clear();
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlCommand command = new SqlCommand("select * from Users", conn);
            using SqlDataReader datas = command.ExecuteReader();
            while (datas.Read())
            {
                dataGridView1.Rows.Add(datas[0], datas[1], datas[2]);
            }

        }
        bool CreateData(string name, string surname)
        {
            if (name.Length < 3 || surname.Length < 3)
            {
                MessageBox.Show("Daxil olunan deyerlerde yalnisliq var");
                return false;
            }
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlCommand command = new SqlCommand($"INSERT INTO People VALUES (N'{name}',N'{surname}')", conn);
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }

        void Delete(string id)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlCommand command = new SqlCommand($"DELETE Users WHERE Id = {id}", conn);
            var result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Silindi");
            }
            else
            {
                MessageBox.Show("Gozlenilmez xeta bas verdi");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var data = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            string id = data.Cells[0].Value.ToString();
            Delete(id);
            GetDatas();
        }
        
        void GetAll()
        {
            using SqlConnection conn = new SqlConnection();
                conn.Open();
            using SqlCommand command = new SqlCommand($"SELECT * FROM Users WHERE Id = {id}", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

        }

        void GetById()
        {
            DataTable dataTable = new DataTable();
            using SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
            using SqlCommand command = new SqlCommand($"SELECT * FROM Users WHERE Id = {id}", conn);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
            if (dataTable.Rows.Count > 0)
                return dataTable.Rows[0];
            else
                return null;
        }


    }
}
