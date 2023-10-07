use std::io;

fn main() {
    let t: i32 = input_line().trim().parse().unwrap();
    for _i in 0..t {
        let n: i32 = input_line().trim().parse().unwrap();
        let nums = input_values();
        println!("{}",solution(n,nums));
    }
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> Vec<i32> {
    let values: Vec<i32> = input_line()
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect();
    values
}

fn solution(n: i32,nums: Vec<i32>) -> i32 {
    let mut cur_min: i32 = std::i32::MAX;
    for i in 0..(n-1) {
        let dif = nums[(i+1) as usize] - nums[i as usize];
        if cur_min > dif {
            cur_min = dif;
        }
    }
    if cur_min <= 0 {0} else {cur_min}
}