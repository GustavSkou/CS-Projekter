class Commands : ProductSystem
{
    protected void UseCommands(string[] command)
    {
        
        switch ( command[ 0 ] )
        {
            case "getprice":
                Console.WriteLine(getPrice(command[1]));
            break;
            
            case "getunitcount":
                Console.WriteLine(getUnitCount(command[1]));
            break;

            case "getallunits":
                foreach (var item in productLookUp)
                {
                    Console.WriteLine(item);
                }
            break;
        }
    }
}