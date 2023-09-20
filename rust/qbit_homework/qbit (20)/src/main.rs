use std::io;

fn main() {
    let values = input_values();
    let (quantity, gold_coins_left, silver_coins_left) = solution(values);

    println!("{}", quantity);
    println!("{} {}", gold_coins_left, silver_coins_left);
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> (u32,u32,u32,u32) {

    let mut values: Vec<u32> = input_line()
        .split_whitespace()
        .map(|q| q.parse().unwrap())
        .collect();

    values.append(&mut input_line()
        .split_whitespace()
        .map(|q| q.parse().unwrap())
        .collect());

    (values[0], values[1], values[2], values[3])
}

fn solution(coins: (u32, u32, u32,u32)) -> (u32, u32, u32) {
    let (gold_coins_price, silver_coins_price, gold_coins, silver_coins) = coins;

    let total_price = gold_coins_price*100 + silver_coins_price;
    let total_wallet = gold_coins*100 + silver_coins;
    let total_left = total_wallet%total_price;
    
    (total_wallet/total_price, total_left/100, total_left%100)
}