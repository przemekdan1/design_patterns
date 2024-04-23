package gui;

import snake_movement.SpeedFast;
import snake_movement.SnakeController;

import java.util.Timer;
import java.util.TimerTask;

public class Main {
    private static MainWindow mainWindow;
    public static MainPanel mainPanel;

    public static void main(String[] args) {


        mainWindow = MainWindow.getInstance();
        mainPanel = mainWindow.getMainPanel();

        startUpGUI();

        SnakeController.gamespeed = new SpeedFast();
        SnakeController.threadID = new Timer();

        SnakeController.threadID.schedule(new TimerTask() {
            @Override
            public void run() {
                SnakeController.moveSnakeAndUpdateGameState();
                mainPanel.repaint();
            }
        }, 0, 70);
    }

    private static void startUpGUI() {
        try {
            javax.swing.SwingUtilities.invokeLater(new Runnable() {
                public void run() {
                    mainWindow.pack();
                    mainWindow.setVisible(true);
                }
            });
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
