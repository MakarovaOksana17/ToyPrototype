
namespace ToyPrototype.Models
{

    public class ProductArticle
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public ProductArticle() { }
        public ProductArticle(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}:{Id},{nameof(Title)}:{Title}";
        }
    }
}
