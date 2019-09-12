package Controller;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import View.HomeView;

public class HomeController {
	private HomeView homeView;
	
	public HomeController() {
		
		homeView = new HomeView();
        
        ActionListener didTouch = new ActionListener() {
		      public void actionPerformed(ActionEvent e) {
		    	  showAlert();
		      }
		 };
        
		 homeView.okButton.addActionListener(didTouch);
		 homeView.setVisible(true);
    }

    public void showAlert(){
      System.out.println("Hello World!");
  }
}
