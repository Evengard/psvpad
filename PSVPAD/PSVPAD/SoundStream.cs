using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using Sce.PlayStation.Core.Audio;
using System.Threading;



namespace PSVPAD
{
	public class SoundStream
	{
		//Reference : https://ccrma.stanford.edu/courses/422/projects/WaveFormat/
		//FILE FORMAT WAVE PCM//Proabably shouldn't change. EXACTLY 44 Bytes 
		const string chunkID = "RIFF";
		//int chunkSize = 0; //size of file - 8 bytes or bytes of data + 36		
		const string format = "WAVE";
		const string subChunk1ID = "fmt "; 
		const int subChunk1Size = 16; 
		const short audioFormat = 1; // 1 = pcm 2 = adpcm
		const short numChannels = 1; 
		const int sampleRate = 22050; 
		const short bitsPerSample = 8; 
		const short blockAlign = (numChannels * bitsPerSample)/8; 
		const string subChunk2ID = "data"; 
		const int byteRate = (sampleRate * numChannels * bitsPerSample)/8;
		//int subChunk2Size = 0; //Size in bytes of data /. num samples * channels * bits per sample/8 
		
		/// <summary>
		/// The buffer queue. -> Holds audio buffers ready to be played. 
		/// Somewhat of a necessity in order to avoid choppy audio stream. 
		/// </summary>
		//Queue<byte[]> bufferQueue; 
		
		//lets try a sound queue 
		Queue<SoundPlayer> soundQueue;
		
		//Wait for buffer to fill before addding it to the queue
		//int bufferMaxSize = 8820; 
		byte[] streamBuffer = new byte[0];
		
		
		//For Playing the audio 
		private SoundPlayer soundPlayer = null; 
		
		/// <summary>
		/// Initializes a new instance of the <see cref="PSVPAD.SoundStream"/> class.
		/// </summary>
		public SoundStream ()
		{
			//bufferQueue = new Queue<byte[]>();
			soundQueue = new Queue<SoundPlayer>();
		}
		
		/// <summary>
		/// Returns the wave buffer complete with header. NOTE: BUFFER RETURNED WILL BE SIZE OF AUDIO BUFFER + 44(Bytes)
		/// Adds the header infromation at the beginning of the buffer ready to be played.
		/// </summary>
		/// <param name='AudioBufferSize'>
		/// Audio buffer size:- 
		/// </param>
		public byte[] compileWaveBuffer(byte[] AudioBuffer){
			
			byte[] wavBuffer = new byte[AudioBuffer.Length + 44];	
			MemoryStream stream = new MemoryStream(wavBuffer);
			
			//FileStream fStream = new FileStream("/Documents/sound.wav",FileMode.Create);	
			BinaryWriter writer = new BinaryWriter(stream, System.Text.Encoding.ASCII);
		    writer.Write(System.Text.Encoding.ASCII.GetBytes(SoundStream.chunkID));
		    writer.Write((int)AudioBuffer.Length+36);//ChunkSize 36+subchunk2size
		    writer.Write(System.Text.Encoding.ASCII.GetBytes(SoundStream.format));
		    writer.Write(System.Text.Encoding.ASCII.GetBytes(SoundStream.subChunk1ID));
		    writer.Write((int)SoundStream.subChunk1Size);
		    writer.Write((short)SoundStream.audioFormat);//encoding  1=pcm encoding 
		    writer.Write((short)SoundStream.numChannels);
		    writer.Write((int)SoundStream.sampleRate);
		    writer.Write((int)SoundStream.byteRate);//(Samplerate * channels * bitrate)/8
		    writer.Write((short)SoundStream.blockAlign);
		    writer.Write((short)SoundStream.bitsPerSample);
		    writer.Write(System.Text.Encoding.ASCII.GetBytes(SoundStream.subChunk2ID));
		    writer.Write((int)AudioBuffer.Length); //Subchunk2Size
			
			writer.Write (AudioBuffer);

			writer.Close();
			
			return wavBuffer;
		}
		
		public void addBuffer(byte[] buffer){
			//adds to stream buffer// if buffer reaches max size then added to queue 
			/*int prevBuffSize = this.streamBuffer.Length;
			Array.Resize(ref this.streamBuffer,prevBuffSize+buffer.Length);
			Array.Copy(buffer,0,this.streamBuffer,prevBuffSize,buffer.Length);
			
			if (this.streamBuffer.Length >= this.bufferMaxSize){
				bufferQueue.Enqueue(this.compileWaveBuffer(this.streamBuffer));
				this.streamBuffer = new byte[0]; 
			}*/
			//bufferQueue.Enqueue(this.compileWaveBuffer(buffer));
			soundQueue.Enqueue((new Sound(this.compileWaveBuffer(buffer))).CreatePlayer());
		}
		
		bool soundPlaying = false; 
		
		//for threading 
		public void updateStream(){
			while (true){
				playStream();	
			}
		}
		
		public void playStream(){
			
			
			//while (true){
				
				if (!soundPlaying){
					if (this.soundQueue.Count > 0){
						this.soundPlaying = true; 	
					}
					else{
						//continue;	
					return;
					}
				}
				
				if (this.soundPlayer == null){
					if (this.soundQueue.Count > 0){
						this.soundPlayer = this.soundQueue.Dequeue();
						this.soundPlayer.PlaybackRate = 1.0f; 
						this.soundPlayer.Play(); 
						//Thread.Sleep(350); 
						
					}
					else{
						soundPlaying = false; 
					}
				}
				else{
					if (this.soundPlayer.Status== SoundStatus.Stopped){
						if (this.soundQueue.Count > 0){
							this.soundPlayer = this.soundQueue.Dequeue();
							this.soundPlayer.PlaybackRate = 1.0f; 
							this.soundPlayer.Play(); 
							//Thread.Sleep(350); 
						}
						else{
							soundPlaying = false; 
						}
					}
				}
				
				/*if (this.soundPlayer != null){
					//if (this.soundPlayer.Status == SoundStatus.Stopped){
					if (this.soundPlayer.Status == SoundStatus.Stopped){
						if (this.bufferQueue.Count > 0){
							this.bufferQueue.Dequeue();
							//load and play next buffer if avilable 
							//this.soundPlayer.Dispose();
							if (this.bufferQueue.Count > 1){
								this.soundPlayer = new Sound(this.bufferQueue.Peek()).CreatePlayer();
								this.soundPlayer.Play();
							}
							else{
								this.soundPlayer.Dispose(); 
								this.soundPlayer = null; 
							}
					
						}
					}
				}
				else{
					//load buffer if available in queue 	
					if (this.bufferQueue.Count > 0){
						//load and play next buffer if avilable 
						this.soundPlayer = new Sound(this.bufferQueue.Peek()).CreatePlayer();
						this.soundPlayer.Play();
					}
				}
				*/
			/*if (this.soundPlayer != null){
					//if (this.soundPlayer.Status == SoundStatus.Stopped){
					if (this.soundPlayer.Status== SoundStatus.Stopped){

						
						
						if (this.soundQueue.Count > 0){
							this.soundQueue.Dequeue();
							//load and play next sound if avilable 
							//this.soundPlayer.Dispose();

							if (this.soundQueue.Count > 1){
								this.soundPlayer = this.soundQueue.Peek().CreatePlayer();
								this.soundPlayer.PlaybackRate = 1f;
								this.soundPlayer.Play();
							}
							else{
								//this.soundPlayer.Play();
								this.soundPlayer.Dispose(); 
								this.soundPlayer = null; 
								this.soundPlaying = false; 	
							}
					
						}
					}
			}
			else{
				if (soundQueue.Count > 1){
					this.soundPlayer = soundQueue.Peek().CreatePlayer();
					this.soundPlayer.PlaybackRate = 1f; 
					this.soundPlayer.Play();
				}
				else{
					//this.soundPlayer.Play();
					this.soundPlaying = false; 	
				}
				
			}
			*/	
				
			//}
			
			
		}
		
		
		
		
		
	}
}

