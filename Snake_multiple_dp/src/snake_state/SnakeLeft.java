package snake_state;

import game.Snake;

public class SnakeLeft extends SnakeState {

    private Snake snake;

    SnakeLeft(Snake snake) {
        this.snake = snake;
    }

    public void add() {

        addByCoordinates(-1,0);

    }


    public SnakeState goUp() {
        return new SnakeUp(snake);
    }

    public SnakeState goDown() {
        return new SnakeDown(snake);
    }

    public SnakeState goRight() {
        return null;
    }

    public SnakeState goLeft() {
        return null;
    }
}
