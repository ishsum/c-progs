namespace ParametersDemo
{
    class Calculator
    {
        int res=0;
        public int Sub(ref int firstnum,ref int secondnum)
        {
            if(secondnum>firstnum)
            {
                res = secondnum - firstnum;
            }
            else
            {
                res = firstnum - secondnum;
            }
            return res;
        }
        

        public void Add(int firstnum, int secondnum,out int sum)
        {
            sum = firstnum + secondnum;
        }   
    }
}
