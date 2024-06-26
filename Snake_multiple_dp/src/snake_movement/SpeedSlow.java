package snake_movement;

import gui.Main;

import java.util.Timer;
import java.util.TimerTask;

public class SpeedSlow implements IGameSpeed {

    private Timer timer = null;

    public Timer getGameSpeed() {
        return null;
    }


    public Timer restartGame( Timer stopTime) {

        stopTime.cancel();
        stopTime.purge();

        timer = new Timer();

        timer.schedule(new TimerTask() {
            @Override
            public void run() {
                SnakeController.moveSnakeAndUpdateGameState();
                Main.mainPanel.repaint();
            }
        }, 0, 120);

        return timer;
    }


}
