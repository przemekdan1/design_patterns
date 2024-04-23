package snake_movement;

import java.util.Timer;

public interface IGameSpeed {
    public Timer timer = null;
    public Timer getGameSpeed();
    public Timer restartGame( Timer stopTime );
}
