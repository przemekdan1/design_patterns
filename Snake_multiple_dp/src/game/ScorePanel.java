package game;

import javax.swing.*;
import java.awt.*;

public class ScorePanel extends JPanel implements IRestart {
    private JLabel scoreLabel;
    private JLabel highScoreLabel;



    public ScorePanel() {
        this.setLayout(new GridLayout(1, 2));
        scoreLabel = new JLabel("<html><font color='green' font size='40'>Score: 0</font></html>");
        highScoreLabel = new JLabel("<html><font color='red' font size='40'>High Score: 0</font></html>");
        this.add(scoreLabel);
        this.add(highScoreLabel);
        GameOver.addRestartable(this); // Add ScorePanel to the list of objects to be restarted
    }

    public void updateScore() {
        int score = Score.getInstance().getScore();
        scoreLabel.setText("<html><font color='green' font size='40'>Score: " + score + "</font></html>");
    }

    public void updateHighScore() {
        int hiscore = Score.getInstance().getHiscore();
        highScoreLabel.setText("<html><font color='red' font size='40'>High Score: " + hiscore + "</font></html>");
    }



    @Override
    public void restart() {
        // Reset the labels when the game is restarted
        scoreLabel.setText("<html><font color='green' font size='40'>Score: 0</font></html>");
    }
}



