namespace HastaneRandevuSistemi.Models
{
    public class Session
    {
        public Dictionary<string, Kullanici> session { get; set; }
        public void setSession(Kullanici k) { session["session"] = k; }
        private static Session _insatance;
        public static Session getInstance()
        {
            if (_insatance == null)
            {
                _insatance = new Session();
            }
            return _insatance;
        }

        public Kullanici getSession() { return session["session"]; }

    }
}
