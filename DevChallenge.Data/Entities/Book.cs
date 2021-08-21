using System.Collections.Generic;

namespace DevChallenge.Data.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string PublishingCompany { get; set; }
        public string ImagePath { get; set; }

        // Multivalues numa coluna (Lista<tipoPrimitivo>) resulta em exception do tipo "System.InvalidOperationException"
        // The property 'Book.Authors' could not be mapped because it is of type 'IEnumerable<string>', which is not a supported primitive type or a valid entity type.
        // Either explicitly map this property, or ignore it using the '[NotMapped]' attribute or by using 'EntityTypeBuilder.Ignore' in 'OnModelCreating'.
        public List<Authors> Authors { get; set; }
    }
}