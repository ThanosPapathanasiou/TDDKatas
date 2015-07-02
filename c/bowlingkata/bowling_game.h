struct bowling_game;
struct bowling_game * bowling_game_create();
  void bowling_game_destroy(struct bowling_game * game);
  void bowling_game_roll(struct bowling_game * game, int pins);
   int bowling_game_score(struct bowling_game * game);
