using System.Data;

namespace LINQToDataTable;

public class LinqToDataTable
{
    public void AddToDataTableDemo()
    {
        DataTable table = new DataTable();
        table.Columns.Add("ID");
        table.Columns.Add("ProductName");
        table.Rows.Add("1", "Chai");
        table.Rows.Add("2", "Queso Cabrels");
        table.Rows.Add("3", "Tofu");
        DisplayProductsFromTable(table);
    }

    public void DisplayProductsFromTable(DataTable table)
    {
        var productNames = from products in table.AsEnumerable() select products.Field<string>("ProductName");
        Console.WriteLine("Product Names: ");
        foreach (string productName in productNames)
            Console.WriteLine(productName);
    }
}
