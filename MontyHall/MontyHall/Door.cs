namespace MontyHall
{
    public class Door
    {
        public bool HasPrize { get; set; }
        public bool IsPicked { get; set; }
        public bool IsOpen { get; set; }
        
        public Door()
        {
            this.IsOpen = false;
            this.IsPicked = false;
            this.HasPrize = false;
        }
        
    }
}