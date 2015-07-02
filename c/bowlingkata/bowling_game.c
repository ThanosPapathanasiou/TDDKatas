#include "bowling_game.h"
#include <stdbool.h>
#include <stdlib.h>

enum {max_rolls = 21};

//helper functions
static bool is_spare(struct bowling_game *game, int frame_index);
static int spare_score(struct bowling_game *game, int frame_index);
static bool is_strike(struct bowling_game *game, int frame_index);
static int strike_score(struct bowling_game *game, int frame_index);


struct bowling_game{
  int rolls[max_rolls];
  int current_roll;
};

struct bowling_game * bowling_game_create(){
  struct bowling_game * game = malloc(sizeof(struct bowling_game));
  for(int i=0; i<max_rolls; i++)
    game->rolls[i] = 0;
  game->current_roll = 0;
  return game;
}

void bowling_game_destroy(struct bowling_game *game){
  free(game);
}

void bowling_game_roll(struct bowling_game *game, int pins){
  game->rolls[game->current_roll++] = pins;
}

int bowling_game_score(struct bowling_game *game){
  int score=0;
  int frame_index=0;

  for(int frame=0; frame<10; ++frame){

    if (is_strike(game,frame_index)){
      score += strike_score(game,frame_index);
      frame_index +=1;
    }else if(is_spare(game,frame_index)){
      score += spare_score(game,frame_index);
      frame_index+=2;
    }else{
      score += game->rolls[frame_index] + game->rolls[frame_index+1];
      frame_index+= 2;
    }

  }
  return score;
}

static bool is_spare(struct bowling_game *game,int frame_index){
  return game->rolls[frame_index] + game->rolls[frame_index] == 10;
}

static int spare_score(struct bowling_game *game,int frame_index){
  return 10 + game->rolls[frame_index+2];
}

static bool is_strike(struct bowling_game *game,int frame_index){
  return game->rolls[frame_index] == 10;
}

static int strike_score(struct bowling_game *game,int frame_index){
  return 10 + game->rolls[frame_index + 1] + game->rolls[frame_index +2];
}
