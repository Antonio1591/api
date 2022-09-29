using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Security.Policy;
using Microsoft.AspNetCore.Mvc;
using petShopTestandoApi.Model;

namespace petShopTestandoApi
{
    public partial class Form1 : Form
    {
        Pessoa pessoa = new Pessoa();
        public Form1()
        {
            InitializeComponent();
        }

        public async Task retornaAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");
            var response = await client.GetAsync("Pessoa");
            var context = await response.Content.ReadAsStringAsync();
             JsonConvert.DeserializeObject<Pessoa[]>(context).ToList();
        }

        private void btnGravarBanco_Click(object sender, EventArgs e)
        {
            
            retornaAsync();
            MessageBox.Show(pessoa.Nome);
        }
    }
}   