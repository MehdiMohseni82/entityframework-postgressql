using SMS.Model;
using SMS.Service.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XMen.Query;

namespace SMS.UI.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////SMS.Model.Cours c = new Model.Cours();
            ////SMS.Repository.SMSDatabaseEntities en = new Repository.SMSDatabaseEntities();

            ////c.Id = Guid.NewGuid();

            ////en.Courses.Add(c);

            ////en.SaveChanges();

            CoursService service = new CoursService(DataStoreContainer.GetDataStore());
            //SMS.Model.Cours c = new Model.Cours();
            //c.Name = "English";

            //service.Add(c);
            Query q = new Query();
            
            q.AddWhere("public.\"Courses\".\"Name\"", XMen.Query.Enums.Comparison.Equals, "English");
            q.SelectFromTable("public.\"Courses\"");

            Service.Service.ServiceResultList<Cours> result = service.GetList(q);
        }
    }
}
