package snake_state;

import game.Snake;

public class SnakeDown extends SnakeState {

    private Snake snake;

    public SnakeDown(Snake snake) {
        this.snake = snake;
    }

    public void add() {
        addByCoordinates(0,1);

    }

    public SnakeState goUp() {
        return null;
    }

    public SnakeState goDown() {
        return null;
    }

    public SnakeState goRight() {
        return new SnakeRight(snake);
    }

    public SnakeState goLeft() {
        return new SnakeLeft(snake);
    }
}
