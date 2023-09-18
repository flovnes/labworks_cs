use std::io;

fn main() {
    let (cages, rabbits) = input_values();

    println!("{}",solution(cages, rabbits));
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> (u64, u64) {
    let values: Vec<u64> = input_line()
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect();
    (values[0], values[1])
}

fn solution(cages: u64, rabbits: u64) -> u64 { 
    if rabbits%cages > 0 {
        rabbits/cages+1
    } else {
        rabbits/cages
    }
}