// See https://aka.ms/new-console-template for more information

Boolean laSNT(int x)
{
    Boolean Flag=false;
    return Flag;
}

int tong = 0, tt = 0;
int N = 100000;
int [] ArrayValues;

ArrayValues = new int [N];
for(int i=0; i<N; i++)
{
    ArrayValues [i] = i;
}

int MaxTT = ArrayValues[0];
for(int i=0; i<N; i++)
{
    if (MaxTT < ArrayValues[i])
    {
        MaxTT = ArrayValues[i];
    }
}
Console.WriteLine ("MaxTT = {0}",MaxTT);

int MaxSS = ArrayValues[0];
int [] LocalMax;
int P = 4;
LocalMax = new int [P];

Parallel.For(0, P, x => {
    int start, end;
    start = x * N / P;
    end = (x+1) * N / P;

    LocalMax[x]=ArrayValues[start];
    for(int j=start+1; j<end; j++)
    {
        if (LocalMax[x] < ArrayValues[j])
        {
            LocalMax[x] = ArrayValues[j];
        }
    }
    Console.WriteLine("MaxSS {0}= {1}", x, LocalMax[x]);
});
Console.WriteLine ("MaxSS = {0}",MaxSS);



/* for(int i = 0; i < N; i++)
{
    tt += i;
}*/
/*Console.WriteLine("Tong tt 0...99 ={0}", tt);*/

/*Parallel.For(0, N, x => {
    Console.WriteLine("\t {0}", x);
    tong += x;
});

Console.WriteLine("Tong 0..99 = {0}",tong);*/

