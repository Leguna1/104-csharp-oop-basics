using P2_2ItemValues;

Item[] items = new Item[3];

// Create and assign values to each Item instance
items[0] = new Item { goldValue = 100 };
items[1] = new Item { goldValue = 200 };
items[2] = new Item { goldValue = 300 };
// Print the goldValue of each Item
for (int i = 0; i < items.Length; i++)
{
    Console.WriteLine($"Item {i + 1}: Gold Value = {items[i].goldValue}");
}

namespace P2_2ItemValues
{
    public class Item
    {
        public int goldValue;

    }

// Declare an array of Item instances
}