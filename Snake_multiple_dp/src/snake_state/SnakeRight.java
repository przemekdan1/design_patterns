package snake_state;

import game.Snake;

public class SnakeRight extends SnakeState {

    private Snake snake;

    SnakeRight(Snake snake) {
        this.snake = snake;
    }

    public void add() {
        // Get coordinates of snake's head

        addByCoordinates(1,0);

    }

    public SnakeState goUp() { return new SnakeUp(snake); }

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
