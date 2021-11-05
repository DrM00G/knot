using System;

public class Program {
  // public int[,] line = new int[4,2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } }; 
  public string[,] newline = new string[3,3] { {"0","b","0"},{"0|","|0","0"},{"0","t","0"} };
  // Console.WriteLine(mn.newline[0]);
  Console.WriteLine("help");
  // public var crosses = 0;
  // public var mn= new Program();
  public static void Main () {
  //   var o_count = 0;
  //   for (int i = 0; i < 3; i++){
  //     for (int j = 0; j < 3; j++){
  //       if (mn.newline[i,j]=="b" or mn.newline[i,j]=="tb"){
  //         if (mn.NextLeftDownHex({i, j},{i, j})){
  //           o_count++;
  //         }
  //       }
  //     }
    // }
  //   // line.add("_");
  //   // line.add("");
  //   Console.WriteLine(o_count);
  }

  // public void NextLeftDownHex(int[] coord,int[] origin){
  //   var move_direction = ((coord[0]%2)-1)
  //   if (mn.newline[coord[0]+1,coord[1]+move_direction]=="rx" or mn.newline[coord[0]+1,coord[1]+move_direction]=="lx"){
  //     return false;
  //   }
  //   if (mn.newline[coord[0]+1,coord[1]+move_direction]=="0|" or mn.newline[coord[0]+1,coord[1]+move_direction]=="||")
  //   {
  //     return mn.NextRightDownHex({coord[0]+1,coord[1]+move_direction},origin);
  //   }
  //   if (mn.newline[coord[0]+1,coord[1]+move_direction]=="t" or mn.newline[coord[0]+1,coord[1]+move_direction]=="tb"){
  //     return mn.NextLeftUpHex({coord[0]+1,coord[1]+move_direction},origin);
  //   }
  //   if (mn.newline[coord[0]+1,coord[1]+move_direction]=="/"){
  //     return mn.NextLeftDownHex({coord[0]+1,coord[1]+move_direction},origin);
  //   }
  //   if ({coord[0]+1,coord[1]+move_direction}==origin){
  //     return true;
  //   }
  // }

  // public void NextRightDownHex(int[] coord,int[] origin){
  //   var move_direction = (-1*((coord[0]+1)%2)+1)
  //   if (mn.newline[coord[0]+1,coord[1]+move_direction]=="rx" or mn.newline[coord[0]+1,coord[1]+move_direction]=="lx"){
  //     return false;
  //   }
  //   if (mn.newline[coord[0]+1,coord[1]+move_direction]=="|0" or mn.newline[coord[0]+1,coord[1]+move_direction]=="||")
  //   {
  //     return mn.NextLeftDownHex({coord[0]+1,coord[1]+move_direction},origin);
  //   }
  //   if (mn.newline[coord[0]+1,coord[1]+move_direction]=="t" or mn.newline[coord[0]+1,coord[1]+move_direction]=="tb"){
  //     return mn.NextRightUpHex({coord[0]+1,coord[1]+move_direction},origin);
  //   }
  //   if (mn.newline[coord[0]+1,coord[1]+move_direction]=="\"){
  //     return mn.NextRightDownHex({coord[0]+1,coord[1]+move_direction},origin);
  //   }
  //   if ({coord[0]+1,coord[1]+move_direction}==origin){
  //     return true;
  //   }
  // }
  

  // public void NextRightUpHex(int[]coord, int[]origin){
  //   var move_direction = (-1*((coord[0]+1)%2)+1)
  //   if (mn.newline[coord[0]-1,coord[1]+move_direction]=="rx" or mn.newline[coord[0]+1,coord[1]+move_direction]=="lx"){
  //     return false;
  //   }
  //   if (mn.newline[coord[0]-1,coord[1]+move_direction]=="|0" or mn.newline[coord[0]+1,coord[1]+move_direction]=="||")
  //   {
  //     return mn.NextLeftUpHex({coord[0]-,coord[1]+move_direction},origin);
  //   }
  //   if (mn.newline[coord[0]-1,coord[1]+move_direction]=="b" or mn.newline[coord[0]+1,coord[1]+move_direction]=="tb"){
  //     return mn.NextRightDownHex({coord[0]-1,coord[1]+move_direction},origin);
  //   }
  //   if (mn.newline[coord[0]-1,coord[1]+move_direction]=="/"){
  //     return mn.NextRightUpHex({coord[0]-1,coord[1]+move_direction},origin);
  //   }
  //   if ({coord[0]-1,coord[1]+move_direction}==origin){
  //     return true;
  //   }
  // }

  // public void NextLeftUpHex(int[] coord,int[] origin){
  //   var move_direction = ((coord[0]%2)-1)
  //   if (mn.newline[coord[0]-1,coord[1]+move_direction]=="rx" or mn.newline[coord[0]+1,coord[1]+move_direction]=="lx"){
  //     return false;
  //   }
  //   if (mn.newline[coord[0]-1,coord[1]+move_direction]=="|0" or mn.newline[coord[0]+1,coord[1]+move_direction]=="||")
  //   {
  //     return mn.NextRightUpHex({coord[0]-,coord[1]+move_direction},origin);
  //   }
  //   if (mn.newline[coord[0]-1,coord[1]+move_direction]=="b" or mn.newline[coord[0]+1,coord[1]+move_direction]=="tb"){
  //     return mn.NextRightDownHex({coord[0]-1,coord[1]+move_direction},origin);
  //   }
  //   if (mn.newline[coord[0]-1,coord[1]+move_direction]=="/"){
  //     return mn.NextRightUpHex({coord[0]-1,coord[1]+move_direction},origin);
  //   }
  //   if ({coord[0]-1,coord[1]+move_direction}==origin){
  //     return true;
  //   }
  // }
  // public void NextLeftHex(coord,origin){
  //   var move_direction = (2*(coord[0]%2)-1)
  //   if (mn.newline[coord[0],coord[1]]=="rx" or mn.newline[coord[0],coord[1]]=="lx"){
  //     return false;
  //   }
  //   if (mn.newline[coord[0],coord[1]]=="l" or mn.newline[coord[0],coord[1]]=="lx")
  //   {
  //     return NextHex(coord[0]+1,coord[1]+move_direction)
  //   }
  // }
}