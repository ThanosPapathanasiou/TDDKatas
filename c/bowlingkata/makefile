bowling_game.o: bowling_game.h bowling_game.c
	gcc -std=c99 bowling_game.c -o bowling_game.o -c

bowling_game_test.o: bowling_game.h bowling_game_test.c
	gcc -std=c99 bowling_game_test.c -o bowling_game_test.o -c

bowling_game_test: bowling_game.o bowling_game_test.o
	gcc -std=c99 -o bowling_game_test.out bowling_game.o bowling_game_test.o

tests: bowling_game_test
	./bowling_game_test.out


clean:
	\rm *.o *.out | clear
