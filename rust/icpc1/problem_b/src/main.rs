use std::io;

fn main() {
    let _ = input_line();
    let nums = input_values();
    println!("{}",solution(nums)%998244353);
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> Vec<i64> {
    let values: Vec<i64> = input_line()
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect();
    values
}

fn solution(nums: Vec<i64>) -> u64 {
    let mut all_perms: Vec<Vec<i64>> = vec![];
    
    for num in &nums {
        let mut temp = Vec::new();
        for index in 1..=(*nums.iter().max().unwrap()+1) {
            if index == 0 {
                continue
            }
            temp.push(num%index);
        }
    all_perms.push(temp);
    
        //debug
        // for i in &temp {
        //     print!("{:2} ", i);
        // }
        // println!("");
        //

        // all_perms.push(temp);
        // println!("{}", temp.len());

        // let result = ((num as f32/2.).ceil()+1.);
        // println!("{}", quant_temp);
    }
    
    
    // for vec in all_perms {
    //     for num in all_perms[vec] {
            
    //     }
    // }

        //debug
        // for i in &all_perms {
        //     print!("{:?} ", i);
        // }
    // println!("{}", temp.len())
}