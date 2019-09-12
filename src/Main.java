import java.awt.EventQueue;
import Controller.HomeController;

public class Main {

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					new HomeController();
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

}
