using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2_01;


namespace Lab2_01
    
{
	class MainClass
	{
		public static void Main (string[] args)
		{

            
			/* Testing the Student class */
			Student[] stds = new Student[7];
			stds[0] = new Student ();
			stds[1] = new Student ("s1",57001);
			stds[2] = new Student ("s2",57002,1994);
			stds[3] = new Student ("s3",57003,1996);
			stds[4] = new Student ("s4",57004);
			stds[5] = new Student ("s5",57005,1993);
			stds[6] = new Student ("s6",57006);
            //stds[0].Student1("John Doe",0,1995,false);
            Console.WriteLine ("\n--- Initial Students' state ---");
			foreach (Student s in stds)
				Console.WriteLine (s.ToString());

			Console.WriteLine ("\n--- Playing with s4, s5, s6 objects ---");
			stds [4].name = "Mario";
			stds [5].yearOfBirth1 = 1900;
			stds [6].Active = true;
			for (int i = 4; i < stds.Length; i++)
				Console.WriteLine (stds [i]);

		}
	}
}
