using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApplication1.Models.Requests
{
    public class PokemonRequest
    {
        private readonly List<int> DEFAULT_EMPTY_MOVELIST = Enumerable.Empty<int>().ToList();
        public PokemonRequest() { }
        public PokemonRequest(string name, string type, List<int> moves)
        {
            Name = name;
            Type = type;
            Moves = DEFAULT_EMPTY_MOVELIST;
        }

        private int _points;

        [JsonPropertyName("points")]
        [NotMapped]
        public string Money
        {
            get
            {
                return _points.ToString("$#.##");
            }
            set
            {
                _points = Convert.ToInt32(value);
            }
        }

        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("moves")]
        public List<int> Moves { get; set; }
        [JsonPropertyName("createdDate")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        [JsonPropertyName("updatedDate")]
        public DateTime? UpdatedDate { get; set; }
    }
}
