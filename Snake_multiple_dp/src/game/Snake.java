package game;

import snake_state.SnakeDown;
import snake_state.SnakeState;

import java.util.ArrayList;
import java.util.List;

public class Snake implements IRestart {
    private static SnakeState state;
    private static List<Field> body = new ArrayList<>();
    private static Field lastRemovedField;

    public Snake() {
        state = new SnakeDown(this);
        lastRemovedField = new Field(10, 9);

        body.add(new Field(10, 10));
        body.add(new Field(10,11));
        GameOver.addRestartable(this);
    }

    public static Field getHead(){return body.get(0);}

    public static boolean isDead() {
        Field head = getHead();
        int headX = head.getX();
        int headY = head.getY();

        return body.lastIndexOf(head) != 0 || headX < 0 || headX > 40 || headY < 0 || headY > 40;
    }

    public void restart() {
        body = new ArrayList<Field>();
        lastRemovedField = new Field(10, 9);
        body.add(new Field(10, 10));
        body.add(new Field(10,11));

    }
    public static List<Field> getSnakeFields() {
        return body;
    }

    public static SnakeState getCurrentState() {
        return state;
    }

    public static Field getLastRemovedField() {
        return lastRemovedField;
    }

    public static void setLastRemovedField(Field lastRemovedField) {
        Snake.lastRemovedField = lastRemovedField;
    }

    public static void setCurrentState(SnakeState state) {
        Snake.state = state;
    }
}
