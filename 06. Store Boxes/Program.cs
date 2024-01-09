namespace _06.Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string info = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (info != "end")
            {
                string[] infoAsArray = info.Split();

                string serialNumber = infoAsArray[0];
                string itemName = infoAsArray[1];
                int itemQuantity = int.Parse(infoAsArray[2]);
                decimal itemPrice = decimal.Parse(infoAsArray[3]);

                Item item = new Item()
                {
                    Name = itemName,
                    Price = itemPrice,
                };

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = item,
                    ItemQuantity = itemQuantity,
                };

                boxes.Add(box);

                info = Console.ReadLine();
            }

            foreach (var box in boxes.OrderByDescending(x => x.PriceForBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:F2}");
            }
        }
    }

    public class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForBox
            => ItemQuantity * Item.Price;
    }
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}