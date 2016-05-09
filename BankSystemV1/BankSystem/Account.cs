
public class Account {

    private double money; //decimal money;
	private string id;
	private string pwd;
	//string name;
	
	public Account( string id, string pwd, double money )
	{
		//if( money < 0 ) throw new Exception("....");
		this.id = id;
		this.pwd = pwd;
		this.money = money;
	}
	
	public double Money
    {
        get{
            return money;
        }
        set
        {
            this.money = value;
        }
    }
	
	public string ID
    {
        set
        {
            this.id = value;
        }
        get
        {
            return id;
        }
    }
		
	public string Password
    {
        get
        {
            return this.pwd;
        }
        set
        {
            pwd = value;
        }

    }
	public virtual bool  SaveMoney( double money)
	{
		if( money < 0 ) return false;  //ÎÀÓï¾ä
		
		this.money += money;
		return true;		
	}
	
	public virtual bool WithdrawMoney( double money)
	{
		if( this.money >= money )
		{
			this.money -= money;
			return true;
		}

		return false;

	}
	
	public bool IsMatch( string id, string pwd )
	{
		return id==this.id && pwd==this.pwd;
	}
	
	
	
}
