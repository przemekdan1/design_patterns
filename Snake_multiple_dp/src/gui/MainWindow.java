package gui;

import game.ScorePanel;
import snake_movement.KeyboardHandler;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class MainWindow extends JFrame {
    private static MainWindow instance = new MainWindow();

    public static MainPanel mainPanel;
    public static ScorePanel scorePanel;
    private JButton startButton;

    public static MainWindow getInstance() {
        return MainWindow.instance;
    }
    public static MainPanel getMainPanel() {
        return mainPanel;
    }

    private MainWindow()
    {
        //window
        this.setTitle("Snake");
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setPreferredSize(new Dimension(1470, 1000));

        mainPanel = new MainPanel();
        this.add(mainPanel, BorderLayout.CENTER);
        this.addKeyListener(KeyboardHandler.getInstance());

        scorePanel = new ScorePanel();
        scorePanel.setBackground(Color.BLACK);
        this.add(scorePanel, BorderLayout.EAST);


    }
}
