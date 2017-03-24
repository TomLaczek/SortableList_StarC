using Starcounter;
using System.Linq;
using System;
using System.Threading;

namespace KitchenSink
{
    partial class SotrableListPage : Json
    {

        //public string FullName => FirstName + " " + LastName;
        //void Handle(Input.SaveTrigger action)
        //{
        //    Transaction.Commit();
        //}
        //void Handle(Input.AddNewExpenseTrigger action)
        //{
        //    var expense = new Expense()
        //    {
        //        Spender = (Person) this.Data,
        //        Amount =  1
        //    };
        //    AddExpense(expense);
        //}
        //public void AddExpense(Expense expense)
        //{
        //    var expenseJson = Self.GET("/KitchenSink/partial/expense/" + expense.GetObjectID());
        //    this.Expenses.Add(expenseJson);
        //}

        protected override void OnData()
        {
            base.OnData();

            SotrableListPage.NameListElementJson name;
            name = this.NameList.Add();
            name.First = "Rocky";
            name.Last = "Rocky";
            name.Id = 0;

            name = this.NameList.Add();
            name.First = "Matylda";
            name.Last = "Rocky";
            name.Id = 2;

            name = this.NameList.Add();
            name.First = "Johny";
            name.Last = "Rocky";
           name.Id = 1;

            name = this.NameList.Add();
            name.First = "Steven";
            name.Last = "Rocky";
            name.Id = 3;

            name = this.NameList.Add();
            name.First = "Sylwester";
            name.Last = "Rocky";
           name.Id = 4;

            name = this.NameList.Add();
            name.First = "Laura";
            name.Last = "Rocky";
            name.Id = 5;
        }
    }
}
