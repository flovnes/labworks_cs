use std::io;

fn main() {
    let t: i32 = input_line().trim().parse().unwrap();
    for _i in 0..t {
        let _ = input_line();
        let nums = input_values();
        solution(nums);
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

fn solution(nums: Vec<i32>) {
    let mut xor_group_j;
    let mut xor_group_k;
    let mut cur_xor = 0;
    let mut cur_and;
    

    'a: for j in 0..nums.len() {
        for k in j..nums.len() {
            let mut xor = Vec::new();
            cur_xor ^= nums[k];
            xor_group_j = j;
            xor_group_k = k;
            for i in xor_group_j..=xor_group_k {
                xor.push(i);
            }

            cur_and = 0;
            for j in 0..nums.len() {
                for k in j..nums.len() {
                    if  k == xor_group_k{
                        continue
                    }
                    cur_and &= nums[k];
                }
            }
        if cur_xor > cur_and {
                
                println!("YES");
                println!("{}", xor.len());
                for pos in xor.clone() {
                    print!("{} ", pos);
                }
                break 'a
            } 
        }
    }   
}