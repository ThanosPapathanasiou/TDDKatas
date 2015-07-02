//bowling_game_test.c
#include "bowling_game.h"
#include <assert.h>
#include <stdbool.h>



static void roll_many(struct bowling_game *, int n, int pins);
static void test_gutter_game();
static void test_all_ones();
static void test_one_spare();
static void test_one_strike();
static void test_perfect_game();

int main(){
  test_gutter_game();
  test_all_ones();
  test_one_spare();
  test_one_strike();
  test_perfect_game();
}

static void roll_many(struct bowling_game * game, int n, int pins){
  for (int i = 0; i < n; i++) {
    bowling_game_roll(game,pins);
  }
}

static void test_gutter_game(){
  struct bowling_game * game = bowling_game_create();
  roll_many(game,20,0);
  assert( bowling_game_score(game) == 0 && "test_gutter_game");
}

static void test_all_ones(){
  struct bowling_game * game = bowling_game_create();
  roll_many(game,20,1);
  assert( bowling_game_score(game) == 20 && "test_all_ones");
}

static void test_one_spare(){
  struct bowling_game * game = bowling_game_create();
  bowling_game_roll(game,5);
  bowling_game_roll(game,5); //spare
  bowling_game_roll(game,3);
  roll_many(game,17, 0);
  assert(bowling_game_score(game)==16 && "test_one_spare");
}

static void test_one_strike(){
  struct bowling_game * game = bowling_game_create();
  bowling_game_roll(game, 10);
  bowling_game_roll(game, 7); //strike
  roll_many(game, 18, 0);
  assert(bowling_game_score(game)==24 && "test_one_strike");
}

static void test_perfect_game(){
  struct bowling_game * game = bowling_game_create();
  roll_many(game,12, 10);
  assert(bowling_game_score(game)==300 && "test_perfect_game");
}
