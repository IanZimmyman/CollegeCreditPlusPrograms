/**
 * 
 */

/**
 * @author cfs_zimmerman
 *
 */
public class Main {

	/**
	 * @param args
	 */
	

		int main()

		{     car junker = new car();

		      System.out.println("Default constructor car");

		      System.out.println("Amount of gas:" + junker.return_gas());

		      System.out.println("Amount of tank:" + junker.return_tank);

		      junker.position();     

		      System.out.println("Parameter constructor car");

		      car mustang = new car (10,1,2,15,1,1);

		      System.out.println("Amount of gas" + mustang.return_gas());

		      System.out.println("Amount of tank" + mustang.return_tank ());

		      mustang.position();

		     

		 

		      System.out.println("lets go for a drive!");

		      mustang.drive();

		      System.out.println("Amount of gas" + mustang.return_gas());

		      mustang.position();

		      System.out.println("lets go for a drive!");

		      mustang.drive();

		      System.out.println("Amount of gas" + mustang.return_gas());

		      mustang.position();

		      System.out.println("lets go for a drive!\n");

		      mustang.drive();

		      System.out.println("Amount of gas" + mustang.return_gas());

		      mustang.position();

		      System.out.println("lets get gas.");

		      mustang.get_gas();

		      System.out.println("Amount of gas" + mustang.return_gas());

		      System.out.println("lets get gas.");

		      mustang.get_gas();

		      System.out.println("Amount of gas" + mustang.return_gas());
		
		}

}
