using System;
using System.Linq;
using System.Web.UI;

namespace SimpleAppWeb
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string TextToDB = TextBox1.Text;
            using (var context = new TestDataBase_DontTouchEntities())
            {
                var NewLine = new TestTable
                {
                    text1 = TextToDB
                };
                context.TestTable.Add(NewLine);
                context.SaveChanges();
            }
        }
    }
}