namespace ClassLibrary
{
    public class Episode
    {
        private int viewerCount;
        private double sumOfRatings;
        private double highestRating;

        public Episode()
        {
            this.viewerCount = 0;
            this.sumOfRatings = 0.0;
            this.highestRating = 0.0;
        }

        public Episode(int viewerCount, double sumOfRatings, double highestRating)
        {
            this.viewerCount = viewerCount;
            this.sumOfRatings = sumOfRatings;
            this.highestRating = highestRating;
        }

        public int GetViewerCount()
        {
            return this.viewerCount;
        }

        public double GetAverageScore()
        {
            return this.sumOfRatings / this.viewerCount;
        }

        public double GetMaxScore()
        {
            return this.highestRating;
        }

        public void AddView(float episodeRating)
        {
            viewerCount++;
            sumOfRatings += episodeRating;
            if(episodeRating > this.highestRating) { highestRating = episodeRating; }
        }
    }
}
