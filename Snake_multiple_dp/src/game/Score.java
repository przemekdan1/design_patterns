package game;

import gui.MainWindow;

public class Score implements IRestart {
    private static Score scoreInstance;
    private int score;
    private int hiscore;

    private Score(){
        score = 0;
        hiscore = 0;
    }

    public int getScore(){
        return this.score;
    }
    public int getHiscore(){return this.hiscore;}


    public static Score getInstance(){
        if(scoreInstance == null){
            scoreInstance = new Score();
            GameOver.addRestartable(scoreInstance);
        }
        return scoreInstance;
    }

    public void updateScore(){
        this.score++;
        if(score > hiscore){
            hiscore = score;
        }
        MainWindow.scorePanel.updateScore();
        MainWindow.scorePanel.updateHighScore();
    }

    public void restart() {
        this.score = 0;
        this.showScore();
    }

    public void showScore(){
        System.out.println("Actual score : " + score);
    }


}
