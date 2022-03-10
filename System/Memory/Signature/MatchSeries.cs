
namespace MemoryManipulator
{
    
    class MatchSeries
    {
        // # of consecutive memory byte matches to signature
        public int series { get; set; }

        // Confirmed series of bytes, read from memory, that match desired signature
        public byte[] matches { get; set; }
     
        public MatchSeries(byte b, int total)
        {
            this.series = 1;
            this.matches = new byte[total];
            this.matches[0] = b;
        }


        // Add a found byte to an existing series - potential match
        public void add(byte b)
        {
            this.matches[this.series] = b;
            this.series++;
        }
    }

    
}
