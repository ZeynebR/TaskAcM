
    public class Car
    {
    protected string _model;
    protected int _topspeed;
    protected double _engine;
    protected double _km;
    protected int _hp;


    public string Model 
    { get
        {
            return _model;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length>10) 
            {
              Console.WriteLine("Model can not be empty or model should contaion maximum 10 characters");
            }
            else
            {
                _model = value;
            }
        }
    }

    public int Topspeed
    {
        get 
        { 
            return _topspeed; 
        }
        set 
        { 
            if (value >=10&& value <=1000) 
            {
            _topspeed = value;  

            }else
            {
                Console.WriteLine(" Topspeed should be between 10 and 1000");    
            }
        }
    }

    public double Engine
    {
        get { return _engine; }
        set
        {
            if(value  >=0.3 && value <=10)
            {
                _engine = value;    
            }else
            {
                Console.WriteLine("Engine should be between 0.3 and 10");
            }
        }
    }

    public double Km
    {
        get { return _km; }
        set
        {
            if(value >= 0)
                {
                _km = value;    
            }
            else
            {
                Console.WriteLine("Km should be 0 or more");
            }
        }
    }

    public int Hp
    {
        get { return _hp; }
        set
        {
            if (value>=50&& value <=1000)
            {
                _hp = value;    
            }else
            {
                Console.WriteLine( "Horse Power should be between 50 and 1000");    
            }
        }
    }

   

}
