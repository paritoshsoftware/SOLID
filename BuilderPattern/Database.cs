namespace DesignPattern
{

    public class Database
    {
        public string host { get; set; }

        public int port { get; set; }

        public string username { get; set; }

        public string password { get; set; }


        private Database(string host, int port, string username, string password)
        {
            this.host = host;
            this.port = port;
            this.username = username;
            this.password = password;
        }



        public static DatabaseBuilder Builder()
        {
            DatabaseBuilder dbBuilder =  new DatabaseBuilder();
            return dbBuilder;
        }

        public class DatabaseBuilder()
        {

            private string _host { get; set; }

            private int _port { get; set; }

            private string _username { get; set; }

            private string _password { get; set; }  
            



            public DatabaseBuilder Host(string host)
            {
                this._host = host;
                return this;
            }

            public DatabaseBuilder Port(int port)
            {
                this._port = port;
                return this;
            }

            public DatabaseBuilder UserName(string username) {
            
                this._username = username;
                return this;
            
            }

            public DatabaseBuilder PassWord(string password)
            {
                this._password = password;
                return this;
            }


            public Database Build()
            {
                Validate();
                return new Database(this._host, this._port,this._username,this._password);
            }



            private void Validate()
            {

                if(!IsHostReachable())
                {
                    throw new Exception("Host not reachable");
                }

                if(!IsPortAvailaible())
                {
                    throw new Exception("Port is not availaible");
                }

                if(!IsUsernameEmpty())
                {
                    throw new Exception("Username  cannot be empty");
                }               

            }

            private bool IsHostReachable()
            {
                return !_host.Equals("222");
                
            }

            private bool IsPortAvailaible()
            {
                return !_port.Equals(8080);              
            }

            private bool IsUsernameEmpty()
            {
                 if(string.IsNullOrEmpty(_username)) return false;
                 else return true;   
            }
        }

        
    }




    

    
}
