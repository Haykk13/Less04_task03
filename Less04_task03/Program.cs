using System;

namespace Less04_task03
{
	class Program
	{
		static void Main(string[] args)
		{
			MyClass my = new MyClass();
			my.Method();
			IInterface1 my1 = my as IInterface1;
			my1.Method();
			IInterface2 my2 = my as IInterface2;
			my2.Method();

		}
	}

	interface IInterface1
	{
		void Method();
	}

	interface IInterface2
	{
		void Method();
	}

	class MyClass : IInterface1, IInterface2
	{
		void IInterface1.Method() { }
		void IInterface2.Method() { }
		public void Method() { }
	}
}