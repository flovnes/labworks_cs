use std::io;

fn main() {
    let (div_part, mod_part) = input_values();
    let (out1, out2) = solution(div_part, mod_part);

    println!("{} {}",out1,out2 );
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

fn solution(div_part: u64, mod_part: u64) -> (u64, u64) { 
    let num = div_part * 37 + mod_part;
    (num/23, num%23)
}