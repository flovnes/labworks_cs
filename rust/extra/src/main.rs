use std::io;
use std::collections::HashSet;
struct Solution;
fn main() {

    // contains_duplicate
    // let nums = input_values();

    // match Solution::contains_duplicate(nums) {
    //     true => println!("Yes"),
    //     false => println!("No")
    // }
    
    // let str = input_line();
    // let other_str = input_line();
    
    // match Solution::is_anagram(str, other_str) {
    //     true => println!("Yes"),
    //     false => println!("No")
    // }

    let position = input_line().trim().parse().unwrap();
    match Solution::ten_power(position) {
        true => println!("position: {}, result: 1", position),
        false => println!("position: {}, result: 0", position)
    }

    let position = input_line().trim().parse().unwrap();
    let value = Solution::ten_eleven(position);
    println!("position: {}, result: {}", position, value);

    let sum = input_line().trim().parse().unwrap();
    let (fives, threes) = Solution::atm(sum);
    println!("sum of {} = 5x{}, 3x{}", sum, fives, threes);

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

impl Solution {
    pub fn contains_duplicate(nums: Vec<i32>) -> bool {
        let mut note = HashSet::new();
        for num in nums.iter(){
            match note.contains(num) {
                true => return true,
                _ => {note.insert(num);}
            }
        }
        false
    }
    pub fn is_anagram(s: String, t: String) -> bool {
        if s.len() != t.len() { return false; }

        let mut letters = [0_i32; 26];

        s.bytes().zip(t.bytes()).for_each(|(u, v)| {
            letters[(u - b'a') as usize] += 1;
            letters[(v - b'a') as usize] -= 1;
        });
        
        for cnt in letters {
            if cnt != 0 { return false; }
        }
        true
    }
    pub fn ten_power(k: u64) -> bool {
        // let mut sqnc = String::new();
        // for i in 0_u32..=10 {
        //     sqnc += &10_u64.pow(i.try_into().unwrap()).to_string();
        // }
        // println!("{}",sqnc);
        // println!("sqnc[{}]: {}",k,sqnc.chars().nth(k as usize - 1).unwrap());

        //110100100010000..
        let value: f64 = ((8.0*k as f64 - 7.0).sqrt() + 1.0)/2.0; 
        if value == value.floor() { return true; }
        false
    }
    pub fn ten_eleven(k: u64) -> u8 {
        // 101112131415..99
        if k%2==0 {
            return ((k/2-1)%10) as u8; 
        } else {
            return (((k+1)/2)/10+1) as u8;
        }
    }
    pub fn atm(sum: u64) -> (u64,u64) {
        // 123 -> 24*5 + 1*3

        match sum%5 {
            0 => { return (sum/5, 0); },
            3 => { return (sum/5, 1); },
            1 => { return (sum/5 - 1, 2); },
            4 => { return (sum/5 - 1, 3); },
            2 => { return (sum/5 - 2, 4); },
            _ => { return (4,4); }
        }
    }
}

#[cfg(test)]
mod tests 
{
    use super::*;

    #[test]
    fn test_contains_duplicate() {
        assert_eq!(Solution::contains_duplicate(vec![1,2,3,1]), true);
        assert_eq!(Solution::contains_duplicate(vec![1,2,3,4]), false);
        assert_eq!(Solution::contains_duplicate(vec![1,1,1,3,3,4,3,2,4,2]), true);
    }

    #[test]
    fn test_is_anagram() {
        assert_eq!(Solution::is_anagram(String::from("anagram"), String::from("nagaram")), true);
        assert_eq!(Solution::is_anagram(String::from("cargo"), String::from("gocar")), true);
        assert_eq!(Solution::is_anagram(String::from("rat"), String::from("car")), false);
    }

    #[test]
    fn test_ten_power() {
        assert_eq!(Solution::ten_power(11), true);
        assert_eq!(Solution::ten_power(44), false);
        assert_eq!(Solution::ten_power(277), true);
    }

    #[test]
    fn test_ten_eleven() {
        assert_eq!(Solution::ten_eleven(20), 9);
        assert_eq!(Solution::ten_eleven(4), 1);
        assert_eq!(Solution::ten_eleven(137), 7);
    }
    
    #[test]
    fn test_atm() {
        assert_eq!(Solution::atm(8), (1, 1));
        assert_eq!(Solution::atm(12), (0, 4));
        assert_eq!(Solution::atm(376), (74, 2));
    }
}