using medicine;

public class Program
{
    static void Main(string[] args)
    {
        // Tạo danh mục thuốc và quản lý
        var manager = new Manager();
        manager.Categories.Add(new Category("Thuốc đau"));
        manager.Categories.Add(new Category("Thuốc hạ sốt"));
        manager.Categories.Add(new Category("Thuốc kháng sinh"));

        // Thêm một số thuốc
        manager.AddDrug("Thuốc đau", new Drug("Paracetamol", 100, 10.5m));
        manager.AddDrug("Thuốc hạ sốt", new Drug("Aspirin", 50, 8.2m));
        manager.AddDrug("Thuốc kháng sinh", new Drug("Amoxicillin", 80, 15.3m));

        // Hiển thị danh sách thuốc theo danh mục
        manager.DisplayDrugsByCategory("Thuốc đau");
        manager.DisplayDrugsByCategory("Thuốc hạ sốt");
        manager.DisplayDrugsByCategory("Thuốc kháng sinh");

        // Hiển thị thông tin chi tiết của một thuốc
        manager.DisplayDrugDetails("Paracetamol");
        manager.DisplayDrugDetails("Aspirin");
        manager.DisplayDrugDetails("Amoxicillin");
    }
}