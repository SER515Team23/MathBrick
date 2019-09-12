package View;

import java.awt.BorderLayout;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

@SuppressWarnings("serial")
public class HomeView extends JFrame {

	public JButton okButton;

	/**
	 * Create the frame.
	 */
	public HomeView() {
		this.setTitle("Math Power!!!");
		setupFrame();
		setupButton();
	}
	
	private void setupFrame() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		JPanel contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		contentPane.setLayout(new BorderLayout(0, 0));
		setContentPane(contentPane);
	}
	
	private void setupButton() {
		okButton = new JButton("OK");
		this.add(okButton);
	}
	
	
}
