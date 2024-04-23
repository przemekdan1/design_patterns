package game;

import java.util.ArrayList;
import java.util.List;

public class GameOver {
    private static List<IRestart> restartables = new ArrayList<IRestart>();
    public static void addRestartable(IRestart r){
        restartables.add(r);
    }
    public static void reset(){
        for(IRestart r:restartables){
            r.restart();
        }
    }
}
