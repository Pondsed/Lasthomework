class Program
{
    public static Tree<string> Diagram = new Tree<string>();
    public static Stack<string> WorkMate = new Stack<string>();
    public static void GetMember(string lastpers){
        int Member = int.Parse(Console.ReadLine());
        if(Member != 0){

            string SubApex = Console.ReadLine();
            Diagram.AddChild(lastpers , SubApex);
            GetMember(SubApex);
            WorkMate.Push(SubApex);

            if(Member >= 1){
                for(int i = 1 ; i < Member ; i++){
                    string SubApex2 = Console.ReadLine();
                    Diagram.AddSibling(WorkMate.Pop() , SubApex2);
                    GetMember(SubApex2);
                    WorkMate.Push(SubApex2);
                }
            }
        }
    }
    static void Main(string[] args){
        string Apex = Console.ReadLine();
        Diagram.AddChild(null , Apex);
        GetMember(Apex);
        string SelectMember = Console.ReadLine();
        Queue<string> UpperBoss = Diagram.ShowLeader(SelectMember);
        int i = 0;
        while(i <= UpperBoss.GetLength()){
            Console.WriteLine(UpperBoss.Pop());
            i++;
        }
    }
}