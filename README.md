# Tower Defense

### [Download](https://github.com/DutchMTC/Tower-Defense/releases/tag/Release)

## Controls
All you need to play the game is your mouse.
You can click the stone to place towers and you can click on towers to inspect them to upgrade or sell them.

## Mechanics
### Buying towers using coins
You can buy towers using your coin balance. You gain coins by killing enemies.
To make this mechanic I spent a lot of time looking into shop system tutorials on YouTube and created a Currency Manager to manage the coin amount, spendings and earnings. The shop is a hidden game object that becomes active once you click on a valid spot to place a tower. 

### Upgrading towers
You can upgrade towers to make them stronger and deal more damage towards enemies.
To make towers upgradable I made a function that changes the damage and speed values of the tower and the cost of the next upgrade.

### Selling towers
You can sell towers and earn back a few coins to place it at another spot or to upgrade another tower.
To sell a tower I made a function that destroys the tower once you click on the sell button and checks the price of the tower and adds half of it back to your coin balance.

```mermaid
flowchart TD

start(((click)))--> can_spawn{can spawn here?}
can_spawn-->|yes| open_shop(open shop)
open_shop--> tower_click{player wants to buy tower?}
can_spawn-->|no| cannot_spawn_error(show error)
cannot_spawn_error--> close_gui
tower_click-->|no| close_gui(close gui)
tower_click-->|yes|take_away_money(take away money)
take_away_money--> buy_more_towers{player wants to buy more towers?}
buy_more_towers-->|no| close_gui(close gui)
buy_more_towers-->|yes| open_shop(open shop)
```
