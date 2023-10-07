use std::io;

fn main() {
    let (a,b) = input_values();
    let ans = input_line().trim().parse().unwrap();
    solution(a,b,ans);
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> (u64,u64) {
    let values: Vec<u64> = input_line()
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect();
    (values[0], values[1])
}

fn solution(a:u64,b:u64,ans:u64) {
    if a+b==ans {
        println!("Accepted");
    } else {
        println!("Wrong answer")
    }
}