use std::io;

fn main() {
    let values = input_values();
    let (out1, out2) = solution(values);
    println!("{} {}", out1, out2);
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> (u32,u32,u32) {
    let values: Vec<u32> = input_line()
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect();
    (values[0], values[1], values[2])
}

fn solution(values: (u32,u32,u32)) -> (u32, u32) {
    let (hectovalue, value, quantity) = values;
    let total_value = (hectovalue * 100 + value) * quantity;
    (total_value/100, total_value%100)
}